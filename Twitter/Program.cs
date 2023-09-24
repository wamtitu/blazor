using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Twitter;
using Twitter.Services.Comments;
using Twitter.Services.Posts;
using Twitter.Services.USers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ICommentInterface, CommentService>();
builder.Services.AddScoped<IPostInterface, PostService>();
builder.Services.AddScoped<IUserInterface, USerService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
