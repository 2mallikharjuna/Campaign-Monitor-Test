import fetch from "node-fetch";

//Fetch all the URL from given website 
async function FetchAllUrls(url) {
  var urlRegex =  /(((https?:\/\/)|(www\.))[^\s]+)/g;
  const response = await fetch(url) // fetch() returns a promise, so we need to wait for it
  let data = await response.text();
  return data.match(urlRegex);    //return matched Url  
};

//Test the href URL
async function asyncFetch(url) {
  try {
    console.log(`passing URL ${url}`);
    const parsedURL = new URL(url);  
    let response = await fetch(parsedURL.href);    
    let data =  `Checking the URL ${parsedURL.href} : Status = ${response.status} and Reponse Code : ${response.statusText}` ;
    return data;   
  }
  catch (error) {
    let data =  `Failed in parsing the URL ${url} with error : ${error}`
    console.error(data);
    return data;   
  }
}

//Create and Executing the tasks in parallel
//Parallel execution : https://jrsinclair.com/articles/2019/how-to-run-async-js-in-parallel-or-sequential/
async function process(arrayOfPromises) {
  console.time(`process`);
  
  const tasks  = arrayOfPromises.map(item => asyncFetch(item)); // Run all our tasks in parallel.
  const results = await Promise.all(tasks);  //capture results

  console.timeEnd(`process`);    
  return results;  
}

//Entry
async function handler(url) {
  let arrayOfUrls = await FetchAllUrls(url);
  const results = await process(arrayOfUrls); // Gather up the results.
  console.log(results);
  
  console.log(`processing is complete`);
}


handler("https://google.com.au"); //Test1
handler("https://www.campaignmonitor.com/"); //Test2
