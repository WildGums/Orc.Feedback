// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="WildGums">
//   Copyright (c) 2008 - 2014 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Feedback.UserEcho
{
    using System;
    using System.Collections.Generic;
    using Catel;
    using RestSharp;

    ///// <summary>
    ///// User echo client.
    ///// </summary>
    ///// <remarks>
    ///// Found at https://github.com/UserEcho/userecho-api-csharp/blob/master/userecho_api.cs
    ///// </remarks>
    //class Client
    //{
    //    private const string ApiUrl = "https://userecho.com/api/";
    //    private const string ClientVersion = "1.0";

    //    private readonly string _apiToken;
    //    private readonly RestClient _client;

    //    public Client(string apiToken)
    //    {
    //        Argument.IsNotNull(() => apiToken);

    //        _apiToken = apiToken;
    //        _client = new RestClient(ApiUrl);
    //    }

    //    public JToken Request(Method method, string path, params KeyValuePair<string, string>[] parameters)
    //    {
    //        var request = new RestRequest(path + ".json", method);

    //        request.AddHeader("Authorization", "Bearer " + _apiToken);
    //        request.AddHeader("Accept", "application/json");
    //        request.AddHeader("API-Client", string.Format("userecho-csharp-{0}", ClientVersion));

    //        if (parameters != null)
    //        {
    //            foreach (var parameter in parameters)
    //            {
    //                //request.AddParameter("application/json", JsonConvert.SerializeObject(parameters), ParameterType.RequestBody);   
    //                request.AddParameter(parameter.Key, parameter.Value);
    //            }
    //        }

    //        var response = _client.Execute(request);
    //        var content = response.Content; // raw content as string

    //        JToken result = null;

    //        try
    //        {
    //            result = JArray.Parse(content);
    //        }

    //        catch
    //        {
    //            throw new UEAPIError(content);
    //        }

    //        return result;
    //    }

    //    public JToken Get(string path)
    //    {
    //        return Request(Method.GET, path);
    //    }

    //    public JToken Post(string path, params KeyValuePair<string, string>[] parameters)
    //    {
    //        return Request(Method.POST, path, parameters);
    //    }

    //    public class UEAPIError : Exception
    //    {
    //        public UEAPIError(string msg) 
    //            : base(msg)
    //        {
    //        }
    //    }
    //}
}