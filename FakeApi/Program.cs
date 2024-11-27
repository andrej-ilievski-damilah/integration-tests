using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;

var wiremockServer = WireMockServer.Start();

Console.WriteLine($"Wiremock is now running on: {wiremockServer.Url}");

wiremockServer
    .Given(Request.Create()
      .WithPath("/users/andrejilievski")
      .UsingGet())
    .RespondWith(Response.Create()
      .WithBody(
        @"{
          ""login"": ""andrejilievski"",
          ""id"": 67104228,
          ""node_id"": ""MDQ6VXNlcjY3MTA0MjI4"",
          ""avatar_url"": ""https://avatars.githubusercontent.com/u/67104228?v=4"",
          ""gravatar_id"": """",
          ""url"": ""https://api.github.com/users/andrejilievski"",
          ""html_url"": ""https://github.com/andrejilievski"",
          ""followers_url"": ""https://api.github.com/users/andrejilievski/followers"",
          ""following_url"": ""https://api.github.com/users/andrejilievski/following{/other_user}"",
          ""gists_url"": ""https://api.github.com/users/andrejilievski/gists{/gist_id}"",
          ""starred_url"": ""https://api.github.com/users/andrejilievski/starred{/owner}{/repo}"",
          ""subscriptions_url"": ""https://api.github.com/users/andrejilievski/subscriptions"",
          ""organizations_url"": ""https://api.github.com/users/andrejilievski/orgs"",
          ""repos_url"": ""https://api.github.com/users/andrejilievski/repos"",
          ""events_url"": ""https://api.github.com/users/andrejilievski/events{/privacy}"",
          ""received_events_url"": ""https://api.github.com/users/andrejilievski/received_events"",
          ""type"": ""User"",
          ""site_admin"": false,
          ""name"": null,
          ""company"": null,
          ""blog"": """",
          ""location"": null,
          ""email"": null,
          ""hireable"": null,
          ""bio"": null,
          ""twitter_username"": null,
          ""public_repos"": 0,
          ""public_gists"": 0,
          ""followers"": 0,
          ""following"": 0,
          ""created_at"": ""2020-06-18T11:47:58Z"",
          ""updated_at"": ""2020-06-18T11:47:58Z""
        }")
      .WithHeader("content-type", "application/json; charset=utf-8")
      .WithStatusCode(200));

Console.ReadKey();
wiremockServer.Dispose();
