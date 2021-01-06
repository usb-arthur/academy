<template>
  <div class="center max-height max-width main  ">
    <div class="center max-height" >
      <div class="box--login center">
        <div class="form--login">
          <div class="center">
            <span class="box__login--title">Đăng nhập</span>
          </div>
          <div>         
            <v-text-field
              v-model="email"
              label="Email"
              required
              type="email"
              append-icon="mdi-email"
            ></v-text-field>
            <v-text-field
              v-model="password"
              label="Mật khẩu"
              required
              type="password"
              append-icon="mdi-lock"          
            ></v-text-field>
          </div>  
          <a class="link-forgot" href="">Quên mật khẩu ?</a>    
          <div class="center">
            <v-btn class="btn-submit mr-4 mt-4" @click="submit"> Đăng nhập </v-btn>
          </div>       
          <div>
            <v-checkbox
              v-model="checkbox"
              label="Lưu đăng nhập"
              required
            ></v-checkbox>
          </div>
          <div class="row">
            <div class="col-6 ">
              <span class="span-login-bottom">Đăng Ký Hoặc Đăng Nhập Với</span>
            </div>
            <div class="col-6 d-flex justify-content-around">
              <div title="facebook" class="mr-4" >
                <svg  class="icon-login" width="55" height="55" viewBox="0 0 55 55" fill="none" xmlns="http://www.w3.org/2000/svg">
                  <path d="M55 27.5C55 12.3122 42.6878 0 27.5 0C12.3122 0 0 12.3122 0 27.5C0 41.2258 10.0563 52.6029 23.2031 54.6659V35.4492H16.2207V27.5H23.2031V21.4414C23.2031 14.5492 27.3088 10.7422 33.5903 10.7422C36.5981 10.7422 39.7461 11.2793 39.7461 11.2793V18.0469H36.2785C32.8625 18.0469 31.7969 20.1668 31.7969 22.3438V27.5H39.4238L38.2046 35.4492H31.7969V54.6659C44.9437 52.6029 55 41.2258 55 27.5Z" fill="#1877F2"/>
                  <path d="M38.2046 35.4492L39.4238 27.5H31.7969V22.3438C31.7969 20.169 32.8625 18.0469 36.2785 18.0469H39.7461V11.2793C39.7461 11.2793 36.5992 10.7422 33.5903 10.7422C27.3088 10.7422 23.2031 14.5492 23.2031 21.4414V27.5H16.2207V35.4492H23.2031V54.6659C26.0504 55.1114 28.9496 55.1114 31.7969 54.6659V35.4492H38.2046Z" fill="white"/>
                </svg>
              </div>
              <div title="twitter" class="mr-4">
                <svg class="icon-login" width="55" height="55" viewBox="0 0 55 55" fill="none" xmlns="http://www.w3.org/2000/svg">
                  <path d="M17.2964 49.8453C38.0512 49.8453 49.4032 32.6501 49.4032 17.7385C49.4032 17.2501 49.4032 16.7639 49.3702 16.2799C51.5786 14.6825 53.485 12.7047 55 10.4389C52.9407 11.3519 50.7559 11.9504 48.5188 12.2143C50.8746 10.8042 52.6377 8.58612 53.4798 5.97293C51.2648 7.28745 48.8415 8.21378 46.3144 8.71193C44.613 6.90284 42.3629 5.7049 39.9121 5.3035C37.4613 4.9021 34.9466 5.31961 32.757 6.49143C30.5674 7.66324 28.8251 9.52404 27.7996 11.7859C26.7741 14.0477 26.5227 16.5844 27.0842 19.0035C22.5979 18.7785 18.209 17.6126 14.2025 15.5814C10.196 13.5503 6.66133 10.6994 3.828 7.21373C2.385 9.69789 1.94304 12.6386 2.5921 15.4372C3.24117 18.2358 4.93245 20.6818 7.3216 22.2771C5.52574 22.2245 3.76898 21.74 2.2 20.8647V21.0077C2.20071 23.613 3.10258 26.1378 4.75262 28.154C6.40267 30.1701 8.69931 31.5535 11.253 32.0693C9.59173 32.5225 7.84867 32.5887 6.1578 32.2629C6.87916 34.5049 8.28307 36.4655 10.1733 37.8705C12.0634 39.2755 14.3454 40.0548 16.7002 40.0993C14.3606 41.9383 11.6813 43.298 8.81575 44.1006C5.95016 44.9031 2.95445 45.1328 0 44.7765C5.16045 48.088 11.1648 49.8446 17.2964 49.8365" fill="#1DA1F2"/>
                </svg>
              </div>
              <div title="google" >
                <svg class="icon-login" width="55" height="55" viewBox="0 0 55 55" fill="none" xmlns="http://www.w3.org/2000/svg">
                  <g clip-path="url(#clip0)">
                    <path d="M54.4638 28.1334C54.4638 26.2641 54.3122 24.3846 53.9889 22.5455H28.05V33.1353H42.904C42.2876 36.5507 40.307 39.572 37.407 41.4919V48.3631H46.2688C51.4728 43.5735 54.4638 36.5002 54.4638 28.1334Z" fill="#4285F4"/>
                    <path d="M28.05 55.0019C35.4668 55.0019 41.7217 52.5666 46.2789 48.3631L37.417 41.4919C34.9515 43.1692 31.7685 44.1191 28.0601 44.1191C20.8857 44.1191 14.8027 39.2789 12.6201 32.7715H3.47528V39.8549C8.14366 49.1411 17.6522 55.0019 28.05 55.0019Z" fill="#34A853"/>
                    <path d="M12.61 32.7715C11.458 29.3561 11.458 25.6578 12.61 22.2424V15.159H3.4753C-0.425118 22.9295 -0.425118 32.0844 3.4753 39.8549L12.61 32.7715Z" fill="#FBBC04"/>
                    <path d="M28.05 10.8846C31.9706 10.824 35.7599 12.2993 38.5993 15.0074L46.4507 7.156C41.4791 2.48762 34.8808 -0.0789846 28.05 0.00185319C17.6522 0.00185319 8.14366 5.86259 3.47528 15.1589L12.6099 22.2423C14.7825 15.7248 20.8756 10.8846 28.05 10.8846Z" fill="#EA4335"/>
                  </g>
                  <defs>
                    <clipPath id="clip0">
                      <rect width="55" height="55" fill="white"/>
                    </clipPath>
                  </defs>
                </svg>
              </div>
            </div>
          </div>
        </div>
      </div>
  </div>
  </div>
</template>

<script>
export default {};
</script>

<style>
.main{
  background-image: url("/src/assets/image/backround-login.svg");
  background-size: 100%;
}

.max-height {
  height: 100%;
}

.max-width {
  width: 100%;
}

.center {
  display: flex;
  justify-content: center;
  align-items: center;
  align-self: center;
}
.box-center {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  align-self: center;
}
.box--login {
  width: 700px;
  height: 470px;
  border: 1px solid red;
  background: rgba(255, 255, 255, 0.2);
  border-radius: 20px;
}

.form--login {
  width: 540px;
  height: 400px;
}
.box__login--title {
  font-family: Roboto;
  font-style: normal;
  font-weight: normal;
  font-size: 35px;
  line-height: 47px;
  color: red;
}
.btn-submit{
  height: 69px;
  width: 325px;
  background-color: #8BCDB9 !important;
  border-radius: 30px !important;
}
.link-forgot{
  font-family: Roboto;
  font-style: normal;
  font-weight: normal;
  font-size: 16px;
  line-height: 29px;
  text-decoration-line: underline;
  color: #FFFFFF;
}
.span-login-bottom{
  font-family: Roboto;
  font-style: normal;
  font-weight: normal;
  font-size: 16px;
  line-height: 29px;
}

.icon-login{
  width: 35px !important;
  height: 35px !important;
  size: 20px;
  cursor: pointer;
}

@media only screen and (max-width: 900px) {
  .box--login {
    width: 350px;
  }
  .form--login{
    width: 200px;
  }
}
</style>