import jquery from 'jquery';

const select = (selector) => {
  console.log('in slide.js select');
  return $(selector);
};

export {
  select
}