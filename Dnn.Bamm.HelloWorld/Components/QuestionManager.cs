/*
' Copyright (c) 2024 BAMM
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using Bamm.Dnn.Dnn.Bamm.HelloWorld.Models;
using DotNetNuke.Data;
using DotNetNuke.Framework;
using System.Collections.Generic;

namespace Bamm.Dnn.Dnn.Bamm.HelloWorld.Components
{
    public interface QuestionManager
    {
        Questions GetQuestionById(int id);

        Answers[] GetAnswerByQuestion(int id);

        Answers[] GetNextQuestionId(int questionId);
    }
}
