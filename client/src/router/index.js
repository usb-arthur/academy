import Vue from "vue";
import VueRouter from "vue-router";
import Home from "../views/Home.vue";

Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    name: "Home",
    component: Home
  },
  {
    path: "/about",
    name: "About",
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () =>
      import(/* webpackChunkName: "about" */ "../views/About.vue")
  },
  {
    path: "/login",
    name: "login",
    meta:{title: 'Login'},
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () =>
      import(/* webpackChunkName: "about" */ "../views/auth/login.vue")
  },
  {
    path: "/register",
    name: "register",
    meta:{title: 'Register'},
    component: () =>
      import(/* webpackChunkName: "about" */ "../views/auth/register.vue")
  },
  {
    path: "/teacher/main",
    name: "Teacher_main",
    meta:{title: 'Teacher'},
    component: () =>
      import(/* webpackChunkName: "about" */ "../views/teacher/main.vue")
  },
  {
    path: "/teacher/course",
    name: "Teacher_course",
    meta:{title: 'Course'},
    component: () =>
      import(/* webpackChunkName: "about" */ "../views/teacher/course.vue")
  }
];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes
});

export default router;
