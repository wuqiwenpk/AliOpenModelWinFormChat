using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AliChat
{
    public class AliAPI
    {
        private static readonly HttpClient httpClient = new HttpClient();
        // 访问阿里，注册并获取api-key https://bailian.console.aliyun.com/?apiKey=1#/api-key
        // 配置你自己的api-ket
        private static string apiKey = "sk-f34f9619ba1846d08eea835efaa8279f";

        /// <summary>
        /// 问答请
        /// </summary>
        /// <param name="text">你的问题</param>
        /// <returns></returns>
        public async static Task<string> Ask(string text)
        {
            // 设置请求 URL 和内容
            string url = "https://dashscope.aliyuncs.com/compatible-mode/v1/chat/completions";
            // 模型名称
            // 访问模型广场选择开源免费的模型 https://bailian.console.aliyun.com/#/model-market
            string modelName = "qwen2-vl-7b-instruct";
            string jsonContent = $"{{\"model\": \"{modelName}\",\"messages\": [{{\"role\": \"user\", \"content\": \"{text}\"}}]}}";


            // 发送请求并获取响应
            string result = await SendPostRequestAsync(url, jsonContent, apiKey);

            return result;
        }

        /// <summary>
        /// 发送请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonContent"></param>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        private static async Task<string> SendPostRequestAsync(string url, string jsonContent, string apiKey)
        {
            using (var content = new StringContent(jsonContent, Encoding.UTF8, "application/json"))
            {
                // 设置请求头
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // 发送请求并获取响应
                HttpResponseMessage response = await httpClient.PostAsync(url, content);

                // 处理响应
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return $"请求失败: {response.StatusCode}";
                }
            }
        }
    }
}
