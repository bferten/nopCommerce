using Nop.Core.Configuration;

namespace Nop.Core.Domain.ArtificialIntelligence;

/// <summary>
/// Artificial intelligence settings
/// </summary>
public partial class ArtificialIntelligenceSettings : ISettings
{
    /// <summary>
    /// Gets or sets a value indicating whether we should use AI
    /// </summary>
    public bool Enabled { get; set; }

    /// <summary>
    /// Gets or sets the AI provider type
    /// </summary>
    public ArtificialIntelligenceProviderType ProviderType { get; set; }

    /// <summary>
    /// Gets or sets the Gemini API key
    /// </summary>
    public string GeminiApiKey { get; set; }

    /// <summary>
    /// Gets or sets the ChatGPT API key
    /// </summary>
    public string ChatGptApiKey { get; set; }

    /// <summary>
    /// Gets or sets the DeepSeek API key
    /// </summary>
    public string DeepSeekApiKey { get; set; }

    /// <summary>
    /// Gets or sets a period (in seconds) before the request times out
    /// </summary>
    public int? RequestTimeout { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether we should use AI to generate product description
    /// </summary>
    public bool AllowGenerateProductDescription { get; set; }

    /// <summary>
    /// Gets or sets a query format string for generate product description with AI
    /// </summary>
    public string ProductDescriptionQuery { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether we should use AI to generate meta keywords
    /// </summary>
    public bool AllowGenerateMetaKeywords { get; set; }

    /// <summary>
    /// Gets or sets a query format string for generate meta keywords with AI
    /// </summary>
    public string MetaKeywordsQuery { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether we should use AI to generate meta description
    /// </summary>
    public bool AllowGenerateMetaDescription { get; set; }

    /// <summary>
    /// Gets or sets a query format string for generate meta description with AI
    /// </summary>
    public string MetaDescriptionQuery { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether we should use AI to generate meta title
    /// </summary>
    public bool AllowGenerateMetaTitle { get; set; }

    /// <summary>
    /// Gets or sets a query format string for generate meta title with AI
    /// </summary>
    public string MetaTitleQuery { get; set; }
}