using Microsoft.Extensions.Options;

namespace webapi_net6_options_pattern;

public class ApplicationOptionsSetup : IConfigureOptions<MySettings>
{
    private readonly IConfiguration _configuration;

    public ApplicationOptionsSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(MySettings options)
    {
        _configuration.GetSection(nameof(MySettings))
            .Bind(options);
    }
}
