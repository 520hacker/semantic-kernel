﻿// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;
using SemanticKernel.Service.Skills.OpenApiSkills.JiraSkill.Model;

namespace SemanticKernel.Service.Skills.OpenApiSkills;

/// <summary>
/// Represents the fields that make up an IssueResponse.
/// </summary>
public class IssueResponseFields
{
    /// <summary>
    /// Gets or sets the ID of the label.
    /// </summary>
    [JsonPropertyName("statuscategorychangedate")]
    public string StatusCategoryChangeDate { get; set; }

    /// <summary>
    /// Gets or sets the name of the label.
    /// </summary>
    [JsonPropertyName("summary")]
    public string Summary { get; set; }

    /// <summary>
    /// Gets or sets the description of the label.
    /// </summary>
    [JsonPropertyName("parent")]
    public IssueResponse Parent { get; set; }

    /// <summary>
    /// Gets or sets the description of the label.
    /// </summary>
    [JsonPropertyName("comment")]
    public CommentResponse CommentResponse { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="IssueResponseFields"/> class.
    /// </summary>
    /// <param name="statuscategorychangedate">The date time the issue was last changed.</param>
    /// <param name="summary">The Summary of the issue.</param>
    /// <param name="parent">The Parent of the issue.</param>
    /// <param name="commentResponse">List of all comments on the issue.</param>
    public IssueResponseFields(string statuscategorychangedate, string summary, IssueResponse parent, CommentResponse commentResponse)
    {
        this.StatusCategoryChangeDate = statuscategorychangedate;
        this.Summary = summary;
        this.Parent = parent;
        this.CommentResponse = commentResponse;
    }
}
