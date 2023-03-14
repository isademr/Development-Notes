function goster(contentId){
    let content = document.getElementById(contentId);
    gizle();
    content.style.display="block";
}
function gizle() {
    var contents = document.getElementsByClassName("tab-content");
    for (let index = 0; index < contents.length; index++) {
        contents[index].style.display="none";
        
    }

}