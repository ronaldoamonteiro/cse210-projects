using System;

class Entry
{
    private string _prompt;
    private string _response;
    private string _date;

    public string Prompt {get {return _prompt;} set {_prompt = value;}}
    public string Response {get {return _response;} set {_response = value;}}
    public string Date {get {return _date;} set {_date = value;}}

    public Entry(string prompt, string response)
    {
        this._prompt = prompt;
        this._response = response;
        _date = DateTime.Now.ToString("dd/MM/yyyy");
    }

    public Entry(string prompt, string response, string date)
    {
        this._prompt = prompt;
        this._response = response;
        this._date = date;
    }

    public override string ToString()
    {
        return $"Date: {_date} | Prompt: {_prompt} | Response: {_response}";
    }
}