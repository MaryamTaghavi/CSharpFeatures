// immutable va mmutable
// immutable cannot change and they are read-only
// they can set values in constructor
// if we want to change value, create a new instance from that
// مصرف حافظه immutable بیشتر از ئmmutable است 
// بنابراین کندتر است
// ولی thread-safe تر است. 
// به این معنا که فرض کن دو تا ترد همزمان بخواهند متغیر را تغییر بدهند اگر immutable باشند
// چون شی جدید میشازد پس تغییرات از بین نمیروند و در نتیجه race-condition وجود ندارد
// اما اگر mmutable باشد و همزمان دو تا ترد بخواهند آن را تغییر دهند ممکن است race-condition به وجود بیاید.
// موضوع تفاوت mmutable با immutable ربطی به referencetype و valuetype ندارد.
