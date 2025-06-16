
function reciveSearch(Q)
{
  if (Q.startsWith("#SRESPONSE")) {
    Q.replace("#SRESPONSE_", "");
    let args;

    args = Q.split("_");
    
    let resp;

    args.forEach(arg => {
        resp += "\n arg"
    });

    alert(resp);
  }
}