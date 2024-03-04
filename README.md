# KidKinder
Gelen mesaj kutusu görünümlü bir form sayfası için aşağıdaki HTML kodunu kullanabilirsiniz:

```html
<div class="container mt-5">
    <div class="row justify-content-center">
        <div class="col-md-6">
            <div class="card">
                <div class="card-header">
                    <h5 class="mb-0">Gelen Mesaj Kutusu</h5>
                </div>
                <div class="card-body">
                    @foreach (var message in Model)
                    {
                        <div class="message">
                            <h6 class="card-subtitle mb-2 text-muted">Gönderen: @message.Name</h6>
                            <p class="card-text">Email: @message.Email</p>
                            <p class="card-text">Mesaj: @message.Message</p>
                        </div>
                        <hr />
                    }
                </div>
            </div>
        </div>
    </div>
</div>
```

Bu kod, Bootstrap'un `card` bileşenini kullanarak gelen mesajları kutu içinde görüntüler. Her mesaj bir kart içinde yer alır ve kart başlığı "Gelen Mesaj Kutusu" olarak belirlenir. Gönderenin adı, email ve mesaj içeriği kartın içinde sıralanır. Bu şekilde kullanıcı dostu bir görünüm elde edilir.