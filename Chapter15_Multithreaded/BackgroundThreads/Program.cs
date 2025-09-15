/*

1- گر همه Foreground Threads تمام شوند، Background Threads ناگهان متوقف می‌شوند.
2- کاربرد : عملیات جانبی یا کم‌اهمیت، مثل لاگ گرفتن یا کارهای پس‌زمینه
3- با ست کردن thread.IsBackground = true می‌توان آن را Background کرد.
4- Background Threads بدون هشدار خاتمه داده می‌شوند

*/