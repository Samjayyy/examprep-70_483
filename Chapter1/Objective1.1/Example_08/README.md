An alternative to the ThreadStaticAttribute is ``ThreadLocal<T>``. It is most useful when your
Thread static context has complex initialization logic. It also acts as a lazy property because 
it is only initializer on first use.