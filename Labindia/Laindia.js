document.getElementById('b').onclick = add;
ds = [];
let n = 0;
let x = 0;
function add() {
n++;
let d = document.getElementById('delo').value;
ds[n] = d;
let br = document.createElement('br');
let bt1 = document.createElement('button');
bt1.textContent = '✓';
bt1.onclick = (event) => {
if (bt1.textContent == '✓')
{
bt1.textContent = 'Не сделано';
}
else
{
bt1.textContent = '✓';
}
};
let nd = document.createElement('text');
nd.innerHTML = d;
let bt2 = document.createElement('button')
bt2.textContent = '×';
bt2.onclick = (event) => {
bt1.remove();
nd.remove();
bt2.remove();
br.remove();
};
if (n % 2 == 0)
{
nd.classList.add("color1");
}
else
{
nd.classList.add("color2");
}
document.body.append(bt1);
document.body.append(nd);
document.body.append(bt2);
document.body.append(br);
}
document.getElementById('c').onclick = clear;
function clear() {
	document.body.remove();
}

