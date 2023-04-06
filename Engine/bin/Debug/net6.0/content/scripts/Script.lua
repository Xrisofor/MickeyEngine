function Start(this)
    
end

function Update(this)

end

function MyFunc(this)
    Music = GetGameObject("Music")
    AudioSource = GetComponent(Music)
    AudioSource.Play()
end