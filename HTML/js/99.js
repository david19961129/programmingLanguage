// 網頁載入完成後執行初始化操作
window.addEventListener('DOMContentLoaded', function() {
    // 範例：導覽菜單點擊時滾動到相應區塊
    var navLinks = document.querySelectorAll('nav ul li a');
    for (var i = 0; i < navLinks.length; i++) {
      navLinks[i].addEventListener('click', function(e) {
        e.preventDefault();
        var target = this.getAttribute('href');
        var targetElement = document.querySelector(target);
        if (targetElement) {
          window.scrollTo({
            top: targetElement.offsetTop,
            behavior: 'smooth'
          });
        }
      });
    }
  });