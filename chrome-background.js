//process functions that need higher permission


chrome.tabs.onUpdated.addListener(function(tabId, changeInfo, tab) {

	if (tab.url.indexOf("google.com/search")>-1)
    console.log(111)
	//   chrome.tabs.update(tab.id, {url: chrome.extension.getURL("/index.html") });
		

}); 


// offline storage for debate files, taking messages from http://debatesynergy.com + chrome://ext interface 
function offlineDebate(req, sender, sendResponse) {
  
    console.log(req)

    if (req.getIndex){
        chrome.storage.local.get("index", function(r) { 
            sendResponse(r); 
        }) 
    }

    if (req.setIndex){
        chrome.storage.local.set({"index": req.setIndex})
    }

    if (req.getFile){
          chrome.storage.local.get(req.getFile, function(r) { 
           
              sendResponse(r)
          }) 
    }

    if (req.setFile){

        var file = JSON.parse(req.setFile), id = file.id;


        chrome.storage.local.set({[id]: file.text}) 
    
    }

    return true

}

chrome.runtime.onMessageExternal.addListener( offlineDebate );
chrome.runtime.onMessage.addListener( offlineDebate );







chrome.extension.onMessage.addListener(function(request, sender, sendResponse) {
    switch (request.type){
        case  "openTab":
            chrome.tabs.create({url: request.url});
            break;
    }
});

window.test = function(e){

//	if (e.error)

  //  	if (e.url == "https://debatesynergy.com/")

 	//		 chrome.tabs.update(e.tab.id, {url: chrome.extension.getURL("/index.html")});
		


   };

  	  chrome.webNavigation.onErrorOccurred.addListener(test);