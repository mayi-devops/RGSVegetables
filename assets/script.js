/* Small enhancement: mobile nav toggle */
(function(){
  const btn = document.querySelector('.nav-toggle');
  const nav = document.querySelector('.nav');
  if(btn && nav){
    btn.addEventListener('click',()=>nav.classList.toggle('open'));
  }
})();