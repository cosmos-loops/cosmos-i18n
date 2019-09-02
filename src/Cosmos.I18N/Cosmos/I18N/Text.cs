﻿using System;
using Cosmos.I18N.Core;
using Cosmos.I18N.Core.Extensions;
using Cosmos.I18N.Languages;

namespace Cosmos.I18N
{
    /// <summary>
    /// Text
    /// </summary>
    public struct Text : IText, IEquatable<Text>
    {
        private Locale Language { get; set; }
        private string ResourceKey { get; set; }
        private string OriginText { get; set; }
        private object[] FormatingParameters { get; set; }

        private readonly TranslationProcessor _translationProcessor;

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="resourceKey"></param>
        /// <param name="language"></param>
        public Text(string text, string resourceKey, Locale language)
            : this(text, resourceKey, language, null) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="resourceKey"></param>
        /// <param name="language"></param>
        /// <param name="parameters"></param>
        public Text(string text, string resourceKey, Locale language, params object[] parameters)
        {
            Language = language;
            ResourceKey = resourceKey;
            OriginText = text;
            FormatingParameters = parameters;

            _translationProcessor = StaticInstanceForILanguageServiceProvider.Instance.GetTranslationProcessor();
        }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="processor"></param>
        /// <param name="text"></param>
        /// <param name="resourceKey"></param>
        /// <param name="language"></param>
        public Text(TranslationProcessor processor, string text, string resourceKey, Locale language)
            : this(processor, text, resourceKey, language, null) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="processor"></param>
        /// <param name="text"></param>
        /// <param name="resourceKey"></param>
        /// <param name="language"></param>
        /// <param name="parameters"></param>
        public Text(TranslationProcessor processor, string text, string resourceKey, Locale language, params object[] parameters)
        {
            Language = language;
            ResourceKey = resourceKey;
            OriginText = text;
            FormatingParameters = parameters;

            _translationProcessor = processor ?? throw new ArgumentNullException(nameof(processor));
        }

        /// <summary>
        /// Convert to String
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static implicit operator string(Text t) => t.ToString();

        /// <summary>
        /// To String.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var text = _translationProcessor.Translate(Language, ResourceKey, OriginText);
            if (FormatingParameters != null)
                text = string.Format(text, FormatingParameters);
            return text;
        }

        /// <summary>
        /// Text hashcode
        /// </summary>
        /// <returns></returns>
        public int TextHashCode() => OriginText.GetHashCode();

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Text other)
        {
            return Language == other.Language &&
                   ResourceKey == other.ResourceKey &&
                   OriginText == other.OriginText &&
                   FormatingParameters.EqualsSupportsNull(other.FormatingParameters);
        }
    }
}