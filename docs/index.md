---
layout: post
title: Welcome
---

Welcome, this is a simple brain awake project to wake my brain after a short stay in Hospital, feel free to join in.  

<ul id="bloglist">
{% for post in site.posts %}
            <li>
            <a class="dropdown-item" href="{{ post.url | absolute_url }}">
              {{ post.title }}</a>
              </li>
          {% endfor %}
</ul>